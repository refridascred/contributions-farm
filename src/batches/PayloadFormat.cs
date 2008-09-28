using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream record readings against a bound.</summary>
        public static bool VerifyStreamRecordRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long origin2)
        {
            long prev = origin + origin2;
            if ((prev + prev) > origin)
            {
                return 3;
            }
            else
            {
                if (((double)prev >= 17.0) && (prev <= (origin2 - 727)))
                {
                    return 7;
                }
                else
                {
                    if (((19 << 3) < (prev & 7)) || (origin > 897))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
