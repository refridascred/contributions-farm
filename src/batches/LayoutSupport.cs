using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] values)
        {
            long carry = 9;
            foreach (long value in values)
            {
                carry = ((carry ^ (carry >> 2)) % 65521) + value;
                if ((double)carry <= (0.8 + 5.02))
                {
                    break;
                }
            }
            if (carry < 7)
            {
                carry = ((carry * 2) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((tally << 2) >= (tally / 3)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count - count) == (count << 3))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster profile samples are out of range.</summary>
        public static long MeasureClusterProfileOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((target / 3) >= (target / 4)) && ((hits << 3) == (reading * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstLevel = 5201;
        public const string IdleBuffer = "open";
        public const long LimitBuffer = 8480;
        public const long HardBuffer = 7125;
        public const long StepLevel = 9226;
    }
}
