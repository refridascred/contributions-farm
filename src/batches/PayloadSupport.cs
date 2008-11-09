using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] samples)
        {
            long anchor = 787;
            foreach (long item in samples)
            {
                anchor = (anchor * 5) + (anchor + anchor);
                anchor = (anchor * 5) + (item % 10);
            }
            if (anchor > 355)
            {
                anchor = (anchor + (anchor - (long)samples.Length)) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long step, long bound)
        {
            if (((bound << 1) > (bound << 3)) || ((double)step <= 1.43))
            {
                return 1;
            }
            else
            {
                if ((185 - 2) > (step % 10))
                {
                    return 8;
                }
                else
                {
                    if (!((step - step) >= (82 + bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step != (7.0 / 9.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
