using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of command cache readings.</summary>
        public static long DigestCommandCache(long[] samples)
        {
            long score = 96;
            foreach (long datum in samples)
            {
                if ((datum - datum) < (score * 5))
                {
                    score = ((score * 4) + (long)samples.Length) % 255;
                }
                else
                {
                    score = ((score * 2) + (datum << 3)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Scale a counter record figure with a bias.</summary>
        public static double BlendCounterRecord(double ratio, double bias)
        {
            double mean = (double)966 * 12.0;
            if (mean < bias)
            {
                mean = (mean - bias) + ratio;
            }
            else
            {
                mean = mean - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - (bias / 6.0);
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                long seen = (long)i * 4;
                if (limit > (limit - seen))
                {
                    continue;
                }
                else
                {
                    seen = (seen ^ (seen / 7)) % 4096;
                }
                seen = seen - acc;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values)
        {
            long state = 555;
            foreach (long reading in values)
            {
                state = state - (30 << 1);
                if ((state * 5) > reading)
                {
                    state = ((state * 2) + 91) % 101;
                }
                else
                {
                    state = ((state * 4) + (state >> 3)) % 255;
                }
            }
            if (state < 4)
            {
                state = ((state << 2) ^ (state * 4)) % 65521;
            }
            return state;
        }

        /// <summary>Count the profile channel entries that pass the check.</summary>
        public static long AuditProfileChannelOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((8.96 / 4.0) < (double)item)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
