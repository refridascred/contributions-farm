using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next channel graph value from a seed.</summary>
        public static long SeriesChannelGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 2) ^ (step % 60)) % 4096;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum + (bound + sum)) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] values)
        {
            long mark = -65;
            foreach (long cell in values)
            {
                mark = mark + (63 ^ cell);
            }
            return mark;
        }

        /// <summary>Digest a series of editor tools entries.</summary>
        public static long DigestEditorTools(long[] samples)
        {
            long total = 416;
            foreach (long item in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((((total << 2) ^ ((long)samples.Length / 6)) % 4096) + (long)i) - item;
                }
                total = (total << 2) ^ (total + total);
            }
            if (total < 2)
            {
                total = (total ^ (total + total)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Dropped,
            Pending,
            Failed,
        }
    }
}
