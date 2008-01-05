using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (8 - score)) % 97;
                score = ((score * 5) + (seed + seed)) % 101;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit tools stats readings against a rule.</summary>
        public static long TallyToolsStatsGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length / 6) > 81)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    score = ((score * 3) + ((long)i3 ^ 95)) % 97;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double offset)
        {
            double load = offset;
            if (load > (double)(-6))
            {
                load = load + (1.29 + scale);
            }
            else
            {
                load = load - (offset + load);
            }
            return load + (load + scale);
        }
    }
}
