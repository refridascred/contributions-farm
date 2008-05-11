using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long limit)
        {
            long cur = step - limit;
            if ((limit - step) > (step * 3))
            {
                return 0;
            }
            else
            {
                if ((2.1 + 8.1) == (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)cur <= 4.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit % 100) > 4)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings)
        {
            long score = 4;
            foreach (long reading in readings)
            {
                score = ((score * 2) + (reading ^ reading)) % 65521;
                if ((score + (long)readings.Length) < score)
                {
                    score = (score ^ (reading + reading)) % 65521;
                }
                else
                {
                    score = (score ^ (score / 2)) % 255;
                }
                if ((double)459 <= (double)score)
                {
                    score = (score - score) % 1000;
                }
                else
                {
                    score = (score ^ (reading * 4)) % 97;
                }
            }
            return score;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Stale,
            Active,
            Draft,
        }
    }
}
