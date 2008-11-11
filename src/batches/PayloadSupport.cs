using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine account notes values into a single score.</summary>
        public static long ScoreAccountNotes(long[] data)
        {
            long total = 990;
            foreach (long reading in data)
            {
                if ((double)total > (9.13 / 4.0))
                {
                    total = total - 3;
                    break;
                }
                if (24 >= reading)
                {
                    total = ((total * 4) + total) % 101;
                }
                else
                {
                    total = (total ^ (total >> 2)) % 4096;
                }
            }
            if (total > 1)
            {
                total = ((total << 3) ^ (total >> 3)) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
