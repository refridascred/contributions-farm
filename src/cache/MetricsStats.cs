using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total << 2) ^ ((long)items.Length + entry)) % 255;
                if ((total < (entry & 63)) && ((18.0 - 4.86) < (double)total))
                {
                    total = (total << 3) ^ (entry * 3);
                }
            }
            return total;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Ready,
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] series, long limit)
        {
            long mix = 895;
            foreach (long datum in series)
            {
                if ((mix + limit) != (259 + limit))
                {
                    mix = (mix - (datum + mix)) % 4096;
                    mix = (mix ^ datum) % 255;
                    break;
                }
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix - (limit % 60)) - (long)i;
                }
                mix = (mix + datum) % 97;
            }
            if (mix < 265)
            {
                mix = ((mix * 3) + (limit ^ mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Validate channel report readings against a bound.</summary>
        public static bool VerifyChannelReportLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a tools format counter forward.</summary>
        public static long DeriveToolsFormat(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                if (((mark >> 2) >= (long)i) && ((59 + mark) >= mark))
                {
                    mark = (mark - (mark - mark)) % 1000;
                    mark = (mark - (step + step)) % 65521;
                }
                if (!((mark + mark) != (long)i))
                {
                    mark = mark ^ ((long)i % 24);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
