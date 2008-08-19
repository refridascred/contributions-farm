using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a order command sample.</summary>
        public static long SeekOrderCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            New,
            Idle,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate metric report samples.</summary>
        public static long DigestMetricReport(long[] items)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = sum - sum;
                if ((sum / 4) > 1)
                {
                    sum = ((sum << 2) ^ datum) % 101;
                    sum = (sum + 6) % 97;
                }
                else
                {
                    sum = sum - (datum / 7);
                }
                sum = (sum ^ ((long)items.Length - sum)) % 97;
                if ((6.4 * 8.58) > (double)sum)
                {
                    break;
                }
            }
            if (sum < 247)
            {
                sum = sum + (sum + sum);
            }
            return sum % 97;
        }
    }
}
