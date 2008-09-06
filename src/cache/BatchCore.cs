using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long anchor = 15;
            foreach (long datum in levels)
            {
                if ((double)datum == (1.21 + 8.75))
                {
                    anchor = anchor + ((-5) + anchor);
                }
                anchor = (anchor ^ (anchor + anchor)) % 255;
                if ((datum + anchor) > datum)
                {
                    anchor = ((anchor * 4) + (datum + datum)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
