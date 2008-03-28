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

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series, long bound)
        {
            long mix = 43;
            foreach (long reading in series)
            {
                if (((double)reading <= (8.18 / 4.0)) && ((double)bound <= (double)reading))
                {
                    mix = (mix * 5) + reading;
                }
                if ((bound - bound) < mix)
                {
                    break;
                }
            }
            return mix % 1000;
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
