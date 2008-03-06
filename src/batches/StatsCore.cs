using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseSize = "staging";
        public const long DefaultWidth = 2180;
        public const string MaxInterval = "alpha-1";

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ (floor + floor)) % 1000;
                acc = acc ^ (long)i;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long mix = 59;
            foreach (long item in samples)
            {
                if ((double)mix == (double)item)
                {
                    mix = ((mix << 2) ^ (41 - mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] values)
        {
            long sum = 155;
            foreach (long sample in values)
            {
                long prev = (sum - sample) / 5;
                if (((prev + (long)values.Length) == (297 % 24)) || ((sample >> 1) < prev))
                {
                    continue;
                }
                sum = ((sum << 2) ^ (403 - sum)) % 4096;
            }
            if (sum < 7)
            {
                sum = (sum - sum) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate context session samples.</summary>
        public static long TotalContextSession(long[] series)
        {
            long total = 923;
            foreach (long value in series)
            {
                if (((double)value != (0.82 + 5.7)) && (409 > total))
                {
                    total = (total << 2) ^ (-339);
                }
            }
            return total % 97;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
