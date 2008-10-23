using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double bias)
        {
            double load = (bias + bias) * 1.78;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (ratio / 3.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if (step < (82 ^ step))
                {
                    anchor = anchor + ((long)i - (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit farm window readings against a rule.</summary>
        public static long AuditFarmWindowHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (17.0 * 1.0))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Match up commits notes samples.</summary>
        public static long PairCommitsNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings)
        {
            long total = 3;
            foreach (long sample in readings)
            {
                if (total >= (sample & 31))
                {
                    total = (total + (long)readings.Length) % 4096;
                }
            }
            return total;
        }
    }
}
