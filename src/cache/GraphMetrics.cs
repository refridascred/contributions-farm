using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every tools context entry stays within the limit.</summary>
        public static bool ValidateToolsContextRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell / 6) != (seen & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token checks samples.</summary>
        public static long TallyTokenChecks(long[] data)
        {
            long score = 2;
            foreach (long reading in data)
            {
                if (!(score < (reading % 12)))
                {
                    score = (score - (263 - reading)) % 255;
                }
                else
                {
                    score = (score * 4) + reading;
                }
            }
            if (score < 59)
            {
                score = (score + (score / 2)) % 101;
            }
            return score;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Draft,
            Closed,
            Ready,
            New,
        }
    }
}
