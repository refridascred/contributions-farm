using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools contributi values into a single score.</summary>
        public static long DigestToolsContributi(long[] series)
        {
            long score = 22;
            foreach (long reading in series)
            {
                if (!(score <= (reading - 479)))
                {
                    score = ((score * 5) + (score / 8)) % 97;
                }
                else
                {
                    score = (score << 3) ^ ((long)series.Length << 2);
                }
            }
            return score;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of payload stats entries.</summary>
        public static long TallyPayloadStats(long[] samples)
        {
            long sum = -5;
            foreach (long entry in samples)
            {
                sum = sum ^ (entry + entry);
                if (entry >= (sum >> 5))
                {
                    sum = (sum - (entry + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
