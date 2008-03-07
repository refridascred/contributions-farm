using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + matches) <= (entry / 2))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of contributi record entries.</summary>
        public static long CombineContributiRecord(long[] readings, long target)
        {
            long mark = 0;
            foreach (long value in readings)
            {
                if ((target - target) < (target >> 5))
                {
                    mark = ((mark + (target + mark)) % 101) ^ value;
                }
            }
            return mark;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
