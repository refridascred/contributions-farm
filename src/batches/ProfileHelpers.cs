using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc << 3) ^ ((long)i2 * 3)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleTools = 5.3;
        public const double RetryTimeout = 4.54;
        public const long BaseDepth = 1100;
        public const double MaxTools = 94.53;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long target)
        {
            long state = 7;
            foreach (long item in values)
            {
                state = (((state << 2) ^ ((long)values.Length + state)) % 65521) - target;
                if ((double)item > 2.82)
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state << 2) ^ state;
            }
            return state % 1000;
        }

        /// <summary>Iterate the token queue series from a seed.</summary>
        public static long StepTokenQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                bool ok = ((long)i + mix) >= step;
                if (ok)
                {
                    break;
                }
                else
                {
                    ok = !ok;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count >= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
