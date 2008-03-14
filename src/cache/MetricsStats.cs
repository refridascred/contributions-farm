using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            New,
            Done,
            Pending,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series, long origin)
        {
            long total = 4;
            foreach (long cell in series)
            {
                if ((total << 1) < origin)
                {
                    total = total ^ (origin + cell);
                }
                else
                {
                    total = (total - (origin + total)) % 255;
                }
                if (((cell >> 2) < (origin / 4)) || ((711 * 2) > (cell + 299)))
                {
                    break;
                }
            }
            if (total < 21)
            {
                total = ((total << 2) ^ (63 & 31)) % 255;
            }
            return total;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] series)
        {
            long score = 263;
            foreach (long entry in series)
            {
                score = score ^ (entry << 2);
                if ((entry >> 5) <= score)
                {
                    break;
                }
            }
            if (score < 1)
            {
                score = ((score * 5) + (score << 3)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Blend two batches channel measurements.</summary>
        public static double ScaleBatchesChannel(double gain, double floor)
        {
            double weight = (4.3 - floor) - floor;
            if (weight <= weight)
            {
                weight = weight - (gain + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight - floor)) - (double)(long)i;
            }
            return weight - floor;
        }
    }
}
