using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor + step) % 255) ^ (long)i2;
                }
                anchor = (anchor + 9) % 97;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] levels, long limit)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                total = (total ^ (entry * 3)) % 97;
            }
            if (total < 3)
            {
                total = ((total << 3) ^ (limit % 97)) % 1000;
            }
            return total;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((long)data.Length + item) >= (count + offset))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
