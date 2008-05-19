using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long origin, long offset)
        {
            if ((33 - origin) < (offset & 31))
            {
                return 8;
            }
            else
            {
                if (!(58 >= origin))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] series)
        {
            long mix = -74;
            foreach (long item in series)
            {
                mix = (mix - (mix << 1)) % 4096;
                if ((mix + 897) != (item >> 1))
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = (mix << 3) ^ (-685);
            }
            return mix % 1000;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream editor readings against a rule.</summary>
        public static long MeasureStreamEditorOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3.0 > (double)item) || !(item > (matches % 12)))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
