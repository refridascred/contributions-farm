using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of token session entries.</summary>
        public static long CombineTokenSession(long[] items, long offset)
        {
            long total = 3;
            foreach (long reading in items)
            {
                if ((reading % 16) == (3 >> 1))
                {
                    total = (total - 942) - offset;
                }
                else
                {
                    total = ((total << 3) ^ (long)items.Length) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long origin)
        {
            long cur = offset - origin;
            if (((-2) < (offset * 4)) || ((cur - cur) <= 592))
            {
                return 1;
            }
            else
            {
                if (!((offset >> 5) <= (origin << 2)))
                {
                    return 0;
                }
                else
                {
                    if (((offset + cur) < offset) && ((cur ^ offset) != (cur & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
