using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Roll a contributi context counter forward.</summary>
        public static long RollContributiContext(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = state ^ (limit + (long)i2);
                    state = ((state * 3) + (limit & 255)) % 97;
                }
                state = (state + 5) % 101;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] values, long offset)
        {
            long mix = 9;
            foreach (long datum in values)
            {
                mix = (((mix << 3) ^ (offset + mix)) % 1000) ^ datum;
            }
            return mix;
        }

        /// <summary>Iterate the cluster format series from a seed.</summary>
        public static long SeriesClusterFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (step >> 3)) % 4096;
                result = result - (step + 776);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
