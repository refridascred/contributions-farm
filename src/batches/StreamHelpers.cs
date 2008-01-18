using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next graph tools value from a seed.</summary>
        public static long IterateGraphTools(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score << 3) ^ (step + step)) + (long)i2;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    score = (score ^ (step - step)) + (long)i3;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long origin)
        {
            if ((floor + 804) < (882 / 2))
            {
                return 6;
            }
            else
            {
                if (!((39 + floor) == (floor % 100)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Blend two notes already measurements.</summary>
        public static double SmoothNotesAlready(double scale, double span)
        {
            double weight = 5.0;
            if (weight <= (weight * 0.3))
            {
                weight = weight - (span + weight);
            }
            else
            {
                weight = weight - (scale - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - span) - (double)(long)i;
            }
            return weight + (double)40;
        }

        /// <summary>Roll a session token counter forward.</summary>
        public static long RollSessionToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 2) + (401 << 1)) % 97) - (long)i2;
                    state = (state ^ (long)i) % 255;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
