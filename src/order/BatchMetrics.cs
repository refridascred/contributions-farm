using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format payload readings.</summary>
        public static long TallyFormatPayload(long[] samples)
        {
            long anchor = 97;
            foreach (long value in samples)
            {
                if ((5 < (12 - anchor)) && ((anchor >> 1) >= (anchor + anchor)))
                {
                    anchor = (((anchor << 2) ^ (anchor & 7)) % 1000) - value;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long mix = 41;
            foreach (long datum in items)
            {
                if (mix <= (mix + mix))
                {
                    mix = (((mix * 2) + (mix - 7)) % 255) - datum;
                }
            }
            if (mix > 48)
            {
                mix = ((mix << 3) ^ ((long)items.Length - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
