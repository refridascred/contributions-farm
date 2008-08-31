using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank buffer window input into a small class.</summary>
        public static long ClassifyBufferWindow(long seed, long target)
        {
            if ((target + target) >= target)
            {
                return 2;
            }
            else
            {
                if ((seed & 1) > seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally - item) < 931)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                state = (state + datum) % 97;
                if (state > (datum >> 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a window notes pair into a bucket.</summary>
        public static long GradeWindowNotes(long origin, long origin2)
        {
            long prev = origin + origin2;
            if ((58 % 3) == (origin2 + 77))
            {
                return 4;
            }
            else
            {
                if (((double)origin2 >= (3.5 + 4.21)) && (prev >= (8 / 9)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
