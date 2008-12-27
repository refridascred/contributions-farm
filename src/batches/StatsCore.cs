using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double drift = gain;
            if (drift > (floor / 9.0))
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - (11.0 / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift - (17.0 - drift);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLevel = 8418;
        public const double LimitLayout = 25.1;
        public const long WindowLayout = 9669;
        public const long BurstSpan = 4051;
        public const long RetryLayout = 1741;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((-73) > (2 + hits)) || (((datum % 5) == (507 % 5)) && ((datum >> 1) > (5 % 16))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] items)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                if ((double)mix >= (11.0 / 4.0))
                {
                    mix = (mix + (cell + mix)) % 65521;
                }
                else
                {
                    mix = (mix << 2) ^ (cell >> 3);
                }
            }
            return mix % 97;
        }
    }
}
