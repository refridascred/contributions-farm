using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Draft,
            Dropped,
            Failed,
            Locked,
        }

        /// <summary>Digest a series of support context entries.</summary>
        public static long WeighSupportContext(long[] readings, long floor)
        {
            long score = 10;
            foreach (long datum in readings)
            {
                if ((floor + floor) == (581 / 2))
                {
                    score = (score ^ 750) - datum;
                }
                else
                {
                    score = (score ^ (9 >> 5)) % 255;
                }
            }
            return score;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values, long seed)
        {
            long mark = 93;
            foreach (long datum in values)
            {
                mark = ((mark << 3) ^ (datum & 1)) % 97;
                if ((mark & 15) != (datum - seed))
                {
                    mark = mark ^ (datum >> 5);
                }
                if (seed < (mark % 5))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
