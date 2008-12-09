using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values)
        {
            long sum = 71;
            foreach (long reading in values)
            {
                sum = (sum ^ (sum & 63)) % 1000;
                if ((sum - reading) > sum)
                {
                    sum = (sum * 3) + (sum >> 1);
                }
                if ((sum - sum) == (sum - reading))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] series)
        {
            long carry = 16;
            foreach (long datum in series)
            {
                if ((datum + carry) <= ((-290) - carry))
                {
                    carry = ((carry * 3) + (carry >> 1)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches token series from a seed.</summary>
        public static long DeriveBatchesToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Ready,
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
