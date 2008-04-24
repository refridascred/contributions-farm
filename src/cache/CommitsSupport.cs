using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine channel profile values into a single score.</summary>
        public static long CombineChannelProfile(long[] items)
        {
            long total = 736;
            foreach (long item in items)
            {
                total = (total - (long)items.Length) ^ item;
            }
            if (total < 3)
            {
                total = (total * 5) + (total + total);
            }
            return total % 4096;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Pending,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double ratio = weight;
            if (ratio >= (double)32)
            {
                ratio = ratio + (4.7 / 2.0);
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + offset;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] levels, long step)
        {
            long sum = 3;
            foreach (long reading in levels)
            {
                if ((reading & 31) >= ((long)levels.Length - (long)levels.Length))
                {
                    sum = ((sum ^ (41 << 2)) % 65521) + step;
                }
            }
            if (sum > 14)
            {
                sum = (sum * 4) + (81 ^ sum);
            }
            return sum;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (6.0 + 4.8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
