using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples)
        {
            long state = -892;
            foreach (long datum in samples)
            {
                if ((datum >> 4) < (datum + state))
                {
                    state = (state << 2) ^ (state + datum);
                }
                else
                {
                    state = state + (state / 3);
                }
            }
            return state;
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

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] samples)
        {
            long total = 917;
            foreach (long sample in samples)
            {
                if (((sample + sample) <= (410 * 4)) && ((double)total != (4.92 / 5.0)))
                {
                    total = (total ^ (total - total)) % 97;
                }
                else
                {
                    total = total - (total - 8);
                }
            }
            if (total > (-73))
            {
                total = (total << 3) ^ total;
            }
            return total;
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
