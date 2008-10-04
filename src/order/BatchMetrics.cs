using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Pending,
            Draft,
            Failed,
            New,
        }

        /// <summary>Digest a series of payload batches entries.</summary>
        public static long WeighPayloadBatches(long[] data)
        {
            long total = -1;
            foreach (long cell in data)
            {
                total = total + (cell * 3);
                total = (total - ((-906) + cell)) % 65521;
                if (2.23 >= (double)cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long floor, long floor2)
        {
            if (!((double)floor2 != (7.82 * 1.9)))
            {
                return 1;
            }
            else
            {
                if ((double)floor2 < 6.6)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] values, long origin)
        {
            long mix = 59;
            foreach (long cell in values)
            {
                if ((origin / 8) >= (mix + 284))
                {
                    break;
                }
                if ((cell + 5) >= origin)
                {
                    mix = mix - (origin - cell);
                }
            }
            if (mix < 35)
            {
                mix = (mix ^ origin) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
