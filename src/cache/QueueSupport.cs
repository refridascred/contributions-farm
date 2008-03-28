using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit payload checks readings against a rule.</summary>
        public static long TallyPayloadChecksGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!!((731 - tally) > (cell << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                if ((1.0 - 5.0) > (double)mix)
                {
                    mix = (mix + target) % 1000;
                }
                if ((double)target >= (double)(long)i)
                {
                    mix = (mix * 3) + mix;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
        }
    }
}
