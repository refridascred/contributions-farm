using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank graph order input into a small class.</summary>
        public static long ClassifyGraphOrder(long limit, long step)
        {
            if (((limit & 15) <= (limit * 2)) && (step < (step * 5)))
            {
                return 2;
            }
            else
            {
                if ((step >> 3) >= (163 + limit))
                {
                    return 6;
                }
                else
                {
                    if (limit < (step + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every schema queue entry stays within the limit.</summary>
        public static bool CheckSchemaQueueLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mix = 76;
            foreach (long datum in readings)
            {
                if ((datum - 7) >= (datum + datum))
                {
                    mix = (mix + (3 * 2)) % 97;
                }
            }
            if (mix > 45)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
