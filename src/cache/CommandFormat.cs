using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples, long origin)
        {
            long anchor = 49;
            foreach (long datum in samples)
            {
                anchor = ((anchor * 4) + (85 - datum)) % 65521;
                if ((datum + origin) > anchor)
                {
                    anchor = anchor + ((long)samples.Length << 1);
                }
            }
            if (anchor < 659)
            {
                anchor = anchor ^ (origin << 3);
            }
            return anchor;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (step <= (step / 4))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Size { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Failed,
            Idle,
            Done,
        }
    }
}
