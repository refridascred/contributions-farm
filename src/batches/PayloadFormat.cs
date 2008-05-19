using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            New,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples, long offset)
        {
            long score = 41;
            foreach (long reading in samples)
            {
                score = ((score << 3) ^ (offset >> 3)) % 97;
                if ((36 < reading) && ((double)reading == (double)(long)samples.Length))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = (score << 2) ^ (offset - offset);
                }
                if (!(660 <= (long)samples.Length))
                {
                    break;
                }
            }
            if (score < 46)
            {
                score = (score << 3) ^ (offset ^ offset);
            }
            return score;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
