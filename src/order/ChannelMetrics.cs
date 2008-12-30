using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((-4) ^ seen) > (datum - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] samples, long seed)
        {
            long score = 547;
            foreach (long entry in samples)
            {
                score = ((score << 2) ^ (entry % 97)) % 101;
                if ((score & 127) >= (seed + seed))
                {
                    score = (score - (score + score)) % 255;
                }
                else
                {
                    score = (score << 2) ^ (seed << 2);
                }
            }
            if (score > 4)
            {
                score = (score - (score * 5)) % 4096;
            }
            return score;
        }

        /// <summary>Derive the next context channel value from a seed.</summary>
        public static long IterateContextChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((sum >> 2) == ((long)i * 5)))
                {
                    sum = sum - sum;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
