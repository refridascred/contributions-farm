using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of notes farm entries.</summary>
        public static long DigestNotesFarm(long[] readings)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                if ((score + 5) >= reading)
                {
                    score = score ^ (score % 24);
                }
            }
            return score % 97;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long offset, long target)
        {
            long prev = offset ^ target;
            if ((target - target) <= (target & 255))
            {
                return 6;
            }
            else
            {
                if (((2 + target) != ((-44) * 2)) || (offset < (743 / 2)))
                {
                    return 2;
                }
                else
                {
                    if ((950 / 9) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target - prev) < target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
