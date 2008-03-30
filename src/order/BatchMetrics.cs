using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches - cell) <= target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long limit)
        {
            long sum = 7;
            foreach (long value in samples)
            {
                if ((50 + value) > (value * 5))
                {
                    sum = (sum * 3) + sum;
                }
                else
                {
                    sum = (sum ^ (limit * 5)) % 4096;
                }
                if ((limit >> 5) < 8)
                {
                    break;
                }
            }
            if (sum > 42)
            {
                sum = (sum ^ (sum ^ sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Locked,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of tools payload entries.</summary>
        public static long CombineToolsPayload(long[] values)
        {
            long result = 314;
            foreach (long reading in values)
            {
                if ((result * 3) < (reading + reading))
                {
                    result = (result << 2) ^ 183;
                }
            }
            if (result > 59)
            {
                result = ((result << 2) ^ (4 / 7)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of token already readings.</summary>
        public static long ScoreTokenAlready(long[] values, long offset)
        {
            long sum = 34;
            foreach (long item in values)
            {
                if ((double)offset != (16.0 / 6.0))
                {
                    sum = sum - item;
                }
                else
                {
                    sum = (sum << 2) ^ offset;
                }
            }
            if (sum > (-485))
            {
                sum = (sum + ((-48) >> 3)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double weight = (offset + scale) - scale;
            if (weight >= (scale + 3.0))
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - (double)37;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
