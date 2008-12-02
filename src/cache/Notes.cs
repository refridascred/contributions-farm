using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many schema githubfarm samples are out of range.</summary>
        public static long CountSchemaGithubfarmHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((((datum << 1) >= hits) || ((1.0 / 7.0) < (double)datum)) || (((double)hits > (14.0 * 10.0)) && ((datum << 2) == (7 - hits))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum ^ 719) < (limit >> 1)) || ((datum >= (3 + limit)) && ((465 & 255) <= datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 2) ^ result) % 101;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series, long step)
        {
            long mark = 453;
            foreach (long cell in series)
            {
                if ((6.6 + 14.0) != (double)step)
                {
                    mark = (((mark << 2) ^ (step - 858)) % 4096) + cell;
                }
            }
            if (mark > 4)
            {
                mark = mark ^ mark;
            }
            return mark;
        }
    }
}
