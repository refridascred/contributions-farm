using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph schema entry stays within the limit.</summary>
        public static bool GuardGraphSchemaRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next checks buffer value from a seed.</summary>
        public static long StepChecksBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Find the first already context entry that matches the target.</summary>
        public static long SeekAlreadyContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
