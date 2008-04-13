using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long acc = 517;
            foreach (long sample in values)
            {
                if (!((acc / 2) > (-70)))
                {
                    acc = (acc - (sample << 3)) % 101;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((limit << 1) == (result + result)) && (result < (result * 5)))
                {
                    result = ((result << 3) ^ (result - 91)) % 1000;
                    continue;
                }
                else
                {
                    result = result ^ (limit - result);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up command batches samples.</summary>
        public static long CompareCommandBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - (mix + mix)) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
