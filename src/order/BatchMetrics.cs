using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] samples)
        {
            long mix = 82;
            foreach (long datum in samples)
            {
                if ((datum - mix) != ((-968) + datum))
                {
                    mix = (mix << 2) ^ (272 << 2);
                }
                else
                {
                    mix = (mix - (534 + datum)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of counter window entries.</summary>
        public static long CombineCounterWindow(long[] data, long offset)
        {
            long score = 1;
            foreach (long reading in data)
            {
                score = (score + offset) + reading;
            }
            return score;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Stale,
            Ready,
        }

        /// <summary>Grade a batch contributi value against two limits.</summary>
        public static long RankBatchContributi(long bound, long origin)
        {
            long span = bound ^ origin;
            if (!((16.0 + 4.1) > (double)bound))
            {
                return 4;
            }
            else
            {
                if (((bound + span) < (span & 7)) || (bound >= (origin + origin)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long score = 67;
            foreach (long reading in levels)
            {
                if (3.49 > (double)reading)
                {
                    score = ((score << 2) ^ (score & 15)) % 97;
                }
            }
            return score % 97;
        }
    }
}
