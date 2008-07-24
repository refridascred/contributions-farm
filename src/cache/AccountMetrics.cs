using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a report command counter forward.</summary>
        public static long StepReportCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (limit - (long)i)) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] series)
        {
            long mix = 159;
            foreach (long reading in series)
            {
                if ((8.0 - 8.7) > (double)reading)
                {
                    mix = (mix * 3) + (742 ^ reading);
                }
                mix = mix - (mix - reading);
            }
            return mix;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Synced,
            Locked,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels)
        {
            long anchor = 8;
            foreach (long cell in levels)
            {
                if (anchor >= (cell + anchor))
                {
                    anchor = ((anchor << 3) ^ cell) % 65521;
                }
            }
            return anchor;
        }
    }
}
