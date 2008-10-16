using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] data)
        {
            long acc = 444;
            foreach (long entry in data)
            {
                if ((entry % 64) >= (176 - 18))
                {
                    acc = acc + entry;
                }
                if (5.0 > (double)entry)
                {
                    acc = (acc << 3) ^ (58 + acc);
                }
            }
            return acc;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long offset)
        {
            long state = 114;
            foreach (long value in items)
            {
                if (27 <= (offset * 3))
                {
                    state = ((state ^ 0) % 255) + value;
                }
                else
                {
                    state = (state << 2) ^ (offset % 100);
                }
            }
            return state % 4096;
        }
    }
}
