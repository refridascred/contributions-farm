using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long mix = 5;
            foreach (long cell in series)
            {
                if (mix <= (cell * 4))
                {
                    continue;
                }
                mix = mix - (832 / 4);
            }
            if (mix > (-636))
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
