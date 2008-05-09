using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = -5;
            foreach (long reading in levels)
            {
                if ((double)reading >= (6.0 - 16.0))
                {
                    score = (score + (reading * 5)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of command entry entries.</summary>
        public static long CombineCommandEntry(long[] data, long origin)
        {
            long carry = 9;
            foreach (long item in data)
            {
                if (((double)item <= (2.4 - 3.0)) || ((origin % 60) == (6 % 12)))
                {
                    carry = ((carry * 2) + (origin ^ item)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Failed,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Match up support command samples.</summary>
        public static long CompareSupportCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((count + count) > (count + datum)) && ((count % 60) <= (49 + datum)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
