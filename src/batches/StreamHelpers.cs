using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long seed, long step)
        {
            if ((83 << 1) > (step / 9))
            {
                return 6;
            }
            else
            {
                if (((seed + step) == (step ^ seed)) || (3.0 > (double)seed))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < 3.38)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double scale, double span)
        {
            double load = scale - scale;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load - span)) - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (tally > (sample % 7))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer githubfarm value from a seed.</summary>
        public static long RollBufferGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = carry ^ (35 & 15);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Retry,
            Queued,
            Dropped,
            Ready,
        }
    }
}
