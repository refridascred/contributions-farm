using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate batch token samples.</summary>
        public static long DigestBatchToken(long[] series)
        {
            long mix = 17;
            foreach (long reading in series)
            {
                mix = (mix ^ (626 - mix)) % 65521;
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix << 2) ^ (reading >> 4)) - (long)i;
                }
                if ((double)mix > (double)reading)
                {
                    mix = ((mix << 3) ^ (reading - 16)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Count stats checks pairs that satisfy a relation.</summary>
        public static long PairStatsChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
