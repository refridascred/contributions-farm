using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double gain, double offset)
        {
            double ratio = (13.0 - offset) - (double)553;
            if (ratio <= ratio)
            {
                ratio = ratio + (gain * 2.07);
            }
            else
            {
                ratio = ratio - (4.2 * 11.0);
            }
            return ratio - (double)0;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                if (!(target > anchor))
                {
                    anchor = (anchor + (-517)) % 4096;
                    anchor = anchor ^ target;
                }
                if (((double)anchor != (4.2 * 1.7)) || ((target + target) > target))
                {
                    anchor = ((anchor * 2) + (anchor & 7)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
