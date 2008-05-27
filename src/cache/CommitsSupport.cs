using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!((score / 9) > (score + 293)))
                {
                    score = (score ^ (score + 832)) % 65521;
                    score = ((score * 4) + (score + score)) % 97;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine tools buffer values into a single score.</summary>
        public static long ScoreToolsBuffer(long[] levels)
        {
            long result = 654;
            foreach (long value in levels)
            {
                result = (result + (result & 127)) % 65521;
                result = (result + value) % 97;
            }
            return result % 4096;
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TotalAlreadyBatches(long[] series)
        {
            long anchor = 85;
            foreach (long sample in series)
            {
                anchor = anchor + ((long)series.Length - sample);
            }
            return anchor;
        }

        /// <summary>Iterate the metrics tools series from a seed.</summary>
        public static long IterateMetricsTools(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!(((total - seed) > total) || ((11.0 - 12.0) == (double)seed)))
                {
                    total = (total + (seed - total)) % 4096;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
