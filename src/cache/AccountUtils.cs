using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Adjust a tools notes reading.</summary>
        public static double BlendToolsNotes(double bias, double bias2)
        {
            double bias3 = (bias / 9.0) * 17.0;
            if (bias3 <= bias3)
            {
                bias3 = (bias3 + (bias * 9.1)) + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 + (bias3 / 3.0)) + (double)(long)i;
            }
            return bias3 + (bias * 9.64);
        }
    }
}
