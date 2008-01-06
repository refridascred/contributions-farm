using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (((mix << 3) ^ (origin % 3)) % 65521) ^ (long)i2;
                }
                mix = ((mix * 4) + (mix ^ mix)) % 4096;
                mix = ((mix << 3) ^ (342 * 2)) % 97;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long offset, long step)
        {
            if (step < (777 + step))
            {
                return 7;
            }
            else
            {
                if ((offset << 3) < (step >> 2))
                {
                    return 3;
                }
                else
                {
                    if (2 < (step / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) > (seen % 24))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
