using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Active,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long origin)
        {
            long mark = 72;
            foreach (long datum in data)
            {
                mark = (((mark * 5) + origin) % 4096) - datum;
            }
            if (mark < 802)
            {
                mark = (mark + ((-634) ^ origin)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long step)
        {
            if (((step << 2) > (step << 1)) || ((double)offset == (3.06 + 9.7)))
            {
                return 3;
            }
            else
            {
                if ((step * 4) != (offset ^ offset))
                {
                    return 0;
                }
                else
                {
                    if (!(offset >= (step >> 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset >> 2) < (step ^ step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
