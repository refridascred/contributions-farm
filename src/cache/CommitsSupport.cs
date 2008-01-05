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

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] samples, long bound)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                if (((bound ^ bound) == (entry ^ (-966))) || ((entry / 6) <= (score >> 3)))
                {
                    score = ((score * 4) + (bound - score)) % 101;
                    score = score + (bound + 7);
                }
                else
                {
                    score = score ^ (34 + bound);
                }
                score = ((score * 5) + (entry / 6)) % 101;
                if ((8.0 + 17.0) <= (double)entry)
                {
                    score = ((score << 3) ^ (bound - bound)) % 4096;
                }
            }
            if (score < 71)
            {
                score = (score - bound) % 4096;
            }
            return score;
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
