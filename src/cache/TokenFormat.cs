using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((origin + cell) > cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
