using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values)
        {
            long result = 83;
            foreach (long entry in values)
            {
                if (416 > ((-333) + result))
                {
                    result = ((result ^ (result << 1)) % 65521) + entry;
                }
            }
            return result;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels, long floor)
        {
            long result = 0;
            foreach (long item in levels)
            {
                if ((97 >> 3) <= (result >> 4))
                {
                    result = ((result + (75 >> 2)) % 65521) - floor;
                }
                else
                {
                    result = (result << 2) ^ (item >> 4);
                }
            }
            if (result > 60)
            {
                result = result + (677 / 6);
            }
            return result;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long FoldQueueFormat(long[] levels, long origin)
        {
            long mix = -92;
            foreach (long datum in levels)
            {
                if ((origin ^ 2) < origin)
                {
                    continue;
                }
                else
                {
                    mix = (mix - (origin >> 4)) % 101;
                }
                if (((datum << 1) >= (datum / 4)) && ((datum & 3) != (datum % 5)))
                {
                    mix = (mix << 3) ^ (mix * 5);
                }
                else
                {
                    mix = mix + (origin + datum);
                }
            }
            return mix;
        }
    }
}
