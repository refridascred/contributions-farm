using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                if (!((107 - bound) >= (datum + datum)))
                {
                    carry = carry - (bound - carry);
                }
                else
                {
                    carry = ((carry << 3) ^ 95) % 97;
                }
                if (6 < (datum + datum))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if ((offset - offset) <= offset2)
            {
                return 0;
            }
            else
            {
                if ((2 ^ limit) <= (71 & 127))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a token layout figure with a bias.</summary>
        public static double ProjectTokenLayout(double scale, double offset)
        {
            double drift = scale;
            if (drift <= drift)
            {
                drift = (drift + (double)651) + offset;
            }
            else
            {
                drift = drift - (scale / 4.0);
            }
            return drift + (2.3 / 8.0);
        }
    }
}
