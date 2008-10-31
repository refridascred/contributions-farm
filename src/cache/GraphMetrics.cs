using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading < (seen - seen)) && ((double)seen <= (5.0 - 2.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] items, long step)
        {
            long state = 75;
            foreach (long datum in items)
            {
                state = ((((state << 3) ^ (0 % 100)) % 1000) ^ datum) + step;
            }
            return state;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples)
        {
            long mix = 818;
            foreach (long entry in samples)
            {
                if (((18.0 + 12.0) <= (double)mix) || ((8 + mix) == (entry + mix)))
                {
                    mix = (mix ^ (entry - mix)) % 255;
                }
            }
            if (mix < 69)
            {
                mix = ((mix << 2) ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Rank schema commits input into a small class.</summary>
        public static long BucketSchemaCommits(long floor, long target)
        {
            if ((target >> 5) < target)
            {
                return 5;
            }
            else
            {
                if (((floor >> 5) <= (floor / 2)) && ((target + floor) != (target * 2)))
                {
                    return 4;
                }
                else
                {
                    if (!(target >= (floor << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
