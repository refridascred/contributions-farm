using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of account editor readings.</summary>
        public static long CombineAccountEditor(long[] levels, long floor)
        {
            long mix = 60;
            foreach (long reading in levels)
            {
                mix = (((mix ^ (mix / 5)) % 255) - reading) + floor;
                mix = ((mix * 2) + (mix & 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many contributi route samples are out of range.</summary>
        public static long MeasureContributiRouteHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((-49) - floor) == (matches + floor))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a context batches sample.</summary>
        public static long LookupContextBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
