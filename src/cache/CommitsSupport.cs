using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 1665;
        public const string StepScore = "local-edge";
        public const string SoftScore = "cached-edge";
        public const long WindowEntry = 4309;

        /// <summary>Classify a context filter pair into a bucket.</summary>
        public static long SortContextFilter(long step, long step2)
        {
            if (!((46 + step2) != (step + step2)))
            {
                return 7;
            }
            else
            {
                if ((0 <= (step + step)) || ((step % 8) != (step - step2)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double scale2 = (span + span) + (1.93 - 4.89);
            return scale2 + scale;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] samples)
        {
            long carry = 63;
            foreach (long reading in samples)
            {
                carry = (carry - (carry & 7)) % 97;
                if (reading < (930 - carry))
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry + (carry ^ 67);
            }
            return carry;
        }
    }
}
