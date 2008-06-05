using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(sample < ((long)samples.Length - count)) && ((5.26 * 1.56) != (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items)
        {
            long mix = 51;
            foreach (long entry in items)
            {
                if ((entry - (long)items.Length) >= 9)
                {
                    mix = mix - mix;
                }
            }
            if (mix < (-2))
            {
                mix = (mix ^ (9 * 5)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + result) % 65521;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate order account samples.</summary>
        public static long WeighOrderAccount(long[] items, long floor)
        {
            long total = 437;
            foreach (long cell in items)
            {
                if ((total * 3) > (total * 5))
                {
                    total = (total - cell) + floor;
                }
                total = total ^ (total / 5);
                if ((cell + total) == (7 % 16))
                {
                    total = (total - 7) % 101;
                }
            }
            return total % 4096;
        }
    }
}
