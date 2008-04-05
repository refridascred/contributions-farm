using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)limit > (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((-2) * 5) != (item << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next tools already value.</summary>
        public static double ScaleToolsAlready(double bias, double span)
        {
            double gain = (double)((-49) - 38);
            if (gain > span)
            {
                gain = (gain - (gain * 19.0)) - bias;
            }
            return gain + (gain * 17.0);
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Token { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a support command value against two limits.</summary>
        public static long GradeSupportCommand(long offset, long origin)
        {
            long step = offset - origin;
            if ((origin + step) <= offset)
            {
                return 0;
            }
            else
            {
                if (step <= offset)
                {
                    return 6;
                }
                else
                {
                    if (origin >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] data)
        {
            long carry = 2;
            foreach (long cell in data)
            {
                carry = ((carry + carry) % 101) - cell;
            }
            if (carry > 89)
            {
                carry = (carry ^ (36 % 8)) % 4096;
            }
            return carry;
        }
    }
}
