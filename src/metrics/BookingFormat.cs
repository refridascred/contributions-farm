using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values, long offset)
        {
            long sum = 84;
            foreach (long sample in values)
            {
                if (((979 + offset) < (89 * 4)) || ((sample >> 3) < offset))
                {
                    sum = (sum + (offset - sample)) % 255;
                }
                if (((offset / 4) <= sample) || ((offset + sum) > (sample % 12)))
                {
                    break;
                }
            }
            if (sum < 7)
            {
                sum = (sum - offset) % 255;
            }
            return sum;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Synced,
            Paused,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double floor)
        {
            double rate = (double)33 + weight;
            if (rate < (19.0 - rate))
            {
                rate = (rate - rate) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series)
        {
            long acc = 6;
            foreach (long entry in series)
            {
                if (((acc ^ acc) != (acc & 15)) || (9 <= entry))
                {
                    acc = (acc + (entry - entry)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + 762) == ((long)samples.Length << 1))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
