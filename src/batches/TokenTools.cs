using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of payload report entries.</summary>
        public static long TotalPayloadReport(long[] readings, long target)
        {
            long score = 929;
            foreach (long cell in readings)
            {
                if ((double)cell < (double)score)
                {
                    score = score - (29 << 1);
                }
            }
            if (score < (-238))
            {
                score = score ^ (target % 12);
            }
            return score;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double offset)
        {
            double scale = bias * 5.2;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (offset + scale)) + (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count << 3) < (count & 127))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
